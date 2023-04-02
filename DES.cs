using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;

using System.IO;

namespace Encryption
{
    static class DES
    {
        //перевод изначального текста в массив битов его двоичного представления
        static public BitArray StringToBinary(String input)
        {
            StringBuilder strInput = new StringBuilder();
            foreach (byte b in Encoding.Default.GetBytes(input))
            {
                String str2 = (Convert.ToString(b, 2).PadLeft(8, '0'));
                strInput.Append(str2);
            }
            BitArray bitInput = new BitArray(strInput.Length);
            for (int i = 0; i < strInput.Length; i++)
            {
                if (strInput[i] == '1')
                {
                    bitInput[i] = true;
                }
                else
                {
                    bitInput[i] = false;
                }
            }
            return bitInput;
            //return strInput;
        }
        //перевод массива битов в текст
        static public string BinaryToString(BitArray input)
        {
            string StrInput="";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i])
                {
                    StrInput+='1';
                }
                else
                {
                    StrInput += '0'; ;
                }
            }
            string StrOutput = hit(StrInput);

            return StrOutput;
        }
        static public string hit (string data)
        {
            List<Byte> byteList = new List<Byte>();
            for (int i = 0; i < data.Length; i+=8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.Default.GetString(byteList.ToArray());
        }
        //зашифровка
        static public string Des(String ParentText, String ParentKey)
        {
            BitArray EncryptedText = StringToBinary(ParentText);
            BitArray Key = new BitArray(64);
            Key = StringToBinary(ParentKey);
            List<BitArray> RoundKeys = RoundsKey(Key);

            for (int i = 0; i < EncryptedText.Length; i += 64)
            {
                BitArray BlockOfBits = new BitArray(64);
                for (int j = 0; j < 64; j++)
                {
                    BlockOfBits[j] = EncryptedText[j + i];
                }
                BlockOfBits = IP(BlockOfBits);
                //16 раундов фейстеля
                for (int j = 0; j < 16; j++)
                {
                    BlockOfBits = Feistel(BlockOfBits, RoundKeys[j]);
                }
                BlockOfBits = IPRev(BlockOfBits);
                for (int j = 0; j < 64; j++)
                {
                    EncryptedText[j + i] = BlockOfBits[j];
                }
            }
            string Output = BinaryToString(EncryptedText);
            return Output;
        }
        //расшифровка
        static public string DesRev(String EncryptedText, String ParentKey)
        {
            BitArray ParentText = StringToBinary(EncryptedText);
            BitArray Key = new BitArray(64);
            Key = StringToBinary(ParentKey);
            List<BitArray> RoundKeys = RoundsKey(Key);

            for (int i = 0; i < ParentText.Length; i += 64)
            {
                BitArray BlockOfBits = new BitArray(64);
                for (int j = 0; j < 64; j++)
                {
                    BlockOfBits[j] = ParentText[j + i];
                }
                BlockOfBits = IP(BlockOfBits);
                //16 раундов фейстеля
                for (int j = 15; j >-1; j--)
                {
                    BlockOfBits = FeistelRev(BlockOfBits, RoundKeys[j]);
                }
                BlockOfBits = IPRev(BlockOfBits);
                for (int j = 0; j < 64; j++)
                {
                    ParentText[j + i] = BlockOfBits[j];
                }
            }
            string Output = BinaryToString(ParentText);
            return Output;
        }
        //начальная перестановка блока битов
        static public BitArray IP(BitArray bitIP)
        {
            BitArray bufferIP = new BitArray(64);
            for (int i = 0; i < 64; i++)
            {
                bufferIP[i] = bitIP[i];
            }

            int[] IPArray = { 57, 59, 61, 63, 56, 58, 60, 62 };
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    bitIP[i * 8 + j] = bufferIP[IPArray[i] - 8 * j];
                }
            }
            return bitIP;
        }
        //конечная перестановка блока битов
        static public BitArray IPRev(BitArray bitIP)
        {
            BitArray bufferIP = new BitArray(64);
            for (int i = 0; i < 64; i++)
            {
                bufferIP[i] = bitIP[i];
            }
            int[] IPArray = { 40  ,8   ,48  ,16  ,56  ,24  ,64  ,32  ,39 , 7 ,  47  ,15 , 55 , 23 , 63,  31,
                              38  ,6   ,46  ,14 , 54  ,22  ,62  ,30 , 37 , 5  , 45 , 13 , 53 , 21 , 61,  29,
                              36  ,4   ,44  ,12  ,52  ,20  ,60  ,28  ,35 , 3  , 43  ,11 , 51  ,19 , 59  ,27,
                              34  ,2   ,42 , 10  ,50  ,18  ,58  ,26  ,33  ,1  , 41 , 9   ,49  ,17 , 57 , 25 };
            for (int i = 0; i < 64; i++)
            {
                bitIP[i] = bufferIP[IPArray[i]-1];
            }
            return bitIP;
        }
        //преобразование Фейстеля
        static public BitArray Feistel(BitArray block, BitArray RoundKey)
        {
            BitArray blockL = new BitArray(32);
            BitArray blockR = new BitArray(32);
            for (int i = 0; i < 32; i++)
            {
                blockL[i] = block[i];
                blockR[i] = block[i+32];
            }

            blockL.Xor(f(blockR, RoundKey));

            for (int i = 0; i < 32; i++)
            {
                block[i] = blockR[i];
                block[i + 32] = blockL[i];
            }

            return block;
        }
        //обратное преобразование Фейстеля
        static public BitArray FeistelRev(BitArray block, BitArray RoundKey)
        {
            BitArray blockL = new BitArray(32);
            BitArray blockR = new BitArray(32);
            for (int i = 0; i < 32; i++)
            {
                blockL[i] = block[i];
                blockR[i] = block[i + 32];
            }

            blockR.Xor(f(blockL, RoundKey));

            for (int i = 0; i < 32; i++)
            {
                block[i + 32] = blockL[i];
                block[i] = blockR[i];
            }

            return block;
        }
        //функция шифрования Фейстеля
        static public BitArray f(BitArray blockRorL, BitArray key)
        {
            BitArray bitR = new BitArray(48);
            bitR = E(blockRorL);
            bitR.Xor(key);
            List<BitArray> bitsB = new List<BitArray>(8);
            for (int i = 0; i < 8; i++)
            {
                BitArray Bi = new BitArray(6);
                for (int j = 0; j < 6; j++)
                {
                    Bi[j] = bitR[i*6+j];
                }
                bitsB.Add(Bi);
            }

            int[,,] Si =
            {
                {
                    {14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7},
                    {0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8},
                    {4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0},
                    {15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13}
                },
                {
                    {15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10},
                    {3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5},
                    {0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15},
                    {13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9}
                },
                {
                    {10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8},
                    {13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1},
                    {13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7},
                    {1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3   ,11  ,5   ,2   ,12}
                },
                {
                    {7   ,13  ,14  ,3   ,0   ,6   ,9   ,10  ,1   ,2   ,8   ,5   ,11  ,12  ,4   ,15},
                    {13  ,8   ,11  ,5   ,6   ,15  ,0   ,3   ,4   ,7   ,2   ,12  ,1   ,10  ,14  ,9},
                    {10 , 6  , 9  , 0   ,12 , 11 , 7  , 13 , 15 , 1 ,  3  , 14  ,5  , 2  , 8,   4},
                    {3  , 15  ,0   ,6   ,10  ,1   ,13  ,8   ,9   ,4   ,5   ,11  ,12  ,7   ,2   ,14}
                },
                {
                    {2  , 12 , 4 ,  1 ,  7  , 10 , 11,  6 ,  8 ,  5  , 3  , 15 , 13 , 0  , 14 , 9},
                    {14  ,11  ,2,   12 , 4 ,  7  , 13,  1 ,  5 ,  0   ,15,  10 , 3  , 9 ,  8  , 6},
                    {4   ,2  , 1  , 11 , 10 , 13,  7 ,  8 ,  15 , 9 ,  12,  5 ,  6  , 3 ,  0   ,14 },
                    {11 , 8 ,  12 ,7 ,  1   ,14,  2  , 13  ,6  , 15 , 0 ,  9 ,  10 , 4  , 5 ,  3}
                },
                {
                    {12 , 1 ,  10  ,15 , 9  , 2 ,  6 ,  8 ,  0  , 13 , 3  , 4  , 14 , 7  , 5  , 11},
                    {10 , 15,  4 ,  2  , 7 ,  12,  9  , 5 ,  6 ,  1 ,  13  ,14 , 0 ,  11 , 3   ,8},
                    {9  , 14  ,15 , 5   ,2 ,  8  , 12,  3 ,  7  , 0 ,  4   ,10 , 1  , 13  ,11 , 6},
                    {4  , 3  , 2  , 12,  9 ,  5  , 15 , 10 , 11 , 14 , 1  , 7,   6  , 0,   8 ,  13}
                },
                {
                    {4  , 11 , 2,   14 , 15  ,0  , 8  , 13 , 3   ,12 , 9  , 7 ,  5  , 10 , 6 ,  1},
                    {13 , 0 ,  11 , 7  , 4 ,  9  , 1  , 10  ,14,  3 ,  5 ,  12 , 2   ,15  ,8 ,  6},
                    {1   ,4  , 11 , 13 , 12 , 3 ,  7  , 14 , 10  ,15 , 6   ,8 ,  0  , 5  , 9 ,  2 },
                    {6,   11 , 13,  8  , 1  , 4  , 10 , 7   ,9   ,5  , 0 ,  15 , 14 , 2 ,  3  , 12 }
                },
                {
                    {13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7},
                    {1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2},
                    {7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8},
                    {2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11 }
                }
            };
            BitArray B = new BitArray(32);
            for (int i = 0; i < 8; i++)
            {
                int a = Convert.ToInt32(bitsB[i][0])*2 + Convert.ToInt32(bitsB[i][5]);
                int b = Convert.ToInt32(bitsB[i][1])*2*2*2 + Convert.ToInt32(bitsB[i][2])*2*2 + Convert.ToInt32(bitsB[i][3])*2 + Convert.ToInt32(bitsB[i][4]);
                int value = Si[i, a, b];
                for (int j = 0; j < 4; j++)
                {
                    if (value != 0)
                    {
                        if (value % 2 == 1)
                        {
                            B[i*4 + 3 - j] = true;
                        }
                        else
                        {
                            B[i*4 + 3 - j] = false;
                        }
                        value = value / 2;
                    }
                    else
                    {
                        B[i*4 + 3 - j] = false;
                    }
                }
            }
            B = P(B);
            return B;
        }
        //функция расширения E
        static public BitArray E(BitArray Right)
        {
            BitArray bitE = new BitArray(48);
            bitE[0] = Right[31];
            bitE[47] = Right[0];
            for (int i = 1; i < 6; i++)
            {
                bitE[i] = Right[i - 1];
                bitE[i + 41] = Right[i + 26];
            }
            int[] EArray = { 4, 8, 12, 16, 20, 24 };
            for (int i = 1; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    bitE[i * 6 + j] = Right[EArray[i - 1] + j];
                }
            }
            return bitE;
        }
        //функция перестановки P
        static public BitArray P(BitArray bitB)
        {
            int[] PArray = {16,7,20,21,29,12,28,17,1,15,23,26,5,18,31,10,2,8,24,14,32,27,3,9,19,13,30,6,22,11,4,25};
            BitArray bufferP = new BitArray(32);
            for (int i = 0; i < 32; i++)
            {
                bufferP[i] = bitB[i];
            }
            for (int i = 0; i < 32; i++)
            {
                bitB[i] = bufferP[PArray[i]-1];
            }
            return bitB;
        }

        //Создание раундовых ключей из начального ключа
        static public List<BitArray> RoundsKey(BitArray InitialKey)
        {
            int[] C0Permutation = 
            { 
                56, 48, 40, 32, 24, 16, 8, 0, 57, 49, 41, 33, 25, 17, 9, 1, 58, 50, 42, 34, 26, 18, 10, 2, 59, 51, 43, 35
            };
            int[] D0Permutation = 
            { 
                62, 54, 46, 38, 30, 22, 14, 6, 61, 53, 45, 37, 29, 21, 13, 5, 60, 52, 44, 36, 28, 20, 12, 4, 27, 19, 11, 3
            };
            int[] Shift = 
            { 
                1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1 
            };
            int[] CDPermutation =
            {
                13,16,10,23,0,4,2,27,14,5,20,9,22,18,11,3,25,7,15,6,26,19,12,1,40,51,30,36,46,54,29,39,50,44,32,47,43,48,38,55,33,52,45,41,49,35,28,31
            };               
            
            //биты четности
            BitArray Key = new BitArray(64);
            int k = 0;
            for (int i = 0; i < 64; i++)
            {
                if (InitialKey[i] == true)
                {
                    k++;
                }
                if ((i + 1) % 8 == 0)
                {
                    if (k % 2 == 0)
                    {
                        Key[i] = true;
                    }
                    else
                    {
                        Key[i] = false;
                    }
                    k = 0;
                    continue;
                }
                Key[i] = InitialKey[i];
            }

            BitArray C0 = new BitArray(28);
            BitArray D0 = new BitArray(28);
            for (int i = 0; i < 28; i++)
            {
                C0[i] = Key[C0Permutation[i]];
                D0[i] = Key[D0Permutation[i]];
            }
            
            List<BitArray> Cbits = new List<BitArray>();
            List<BitArray> Dbits = new List<BitArray>();
            Cbits.Add(C0);
            Dbits.Add(D0);


            //циклический сдвиг
            for (int i = 0; i < 16; i++)
            {
                BitArray C = Cbits[i];
                BitArray D = Dbits[i];
                if (Shift[i]==2)
                {
                    bool bufC0 = C[0];
                    bool bufC1 = C[1];
                    bool bufD0 = D[0];
                    bool bufD1 = D[1];
                    for (int m = 0; m < 26; m++)
                    {
                        C[m] = C[m + 2];
                        D[m] = D[m + 2];
                    }
                    C[26] = bufC0;
                    C[27] = bufC1;
                    D[26] = bufD0;
                    D[27] = bufD1;
                }
                if (Shift[i]==1)
                {
                    bool bufC = C[0];
                    bool bufD = D[0];
                    for (int m = 0; m < 27; m++)
                    {
                        C[m] = C[m + 1];
                        D[m] = D[m + 1];
                    }
                    C[27] = bufC;
                    D[27] = bufD;
                }
                Cbits.Add(C);
                Dbits.Add(D);
            }

            List<BitArray> ListRoundKeys = new List<BitArray>(16);
            List<BitArray> ListCD = new List<BitArray>(16);

            //соединяем C с D
            for (int i = 0; i < 16; i++)
            {
                BitArray CD = new BitArray(56);
                for (int j = 0; j < 28; j++)
                {
                    CD[j] = (Cbits[i + 1])[j];
                    CD[j + 28] = (Dbits[i + 1])[j];
                }
                ListCD.Add(CD);
            }
            //перестановка в CD и добавление раундового ключа в список
            for (int i = 0; i < 16; i++)
            {
                BitArray RoundKey = new BitArray(48);
                for (int j = 0; j < 48; j++)
                {
                    RoundKey[j] = ListCD[i][CDPermutation[j]];
                }
                ListRoundKeys.Add(RoundKey);
            }


            return ListRoundKeys;//список ключей на выходе
        }


    }
}
