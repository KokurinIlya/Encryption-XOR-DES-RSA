using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    static class RSA
    {
		//Тест Ферма
        static public bool FermatPrimalityTest(uint x)
        {
			if (x == 2)
            {
				return true;
			}
			Random rand = new Random();
			int counter = 0;
            do
            {
				uint a = (uint)rand.Next(0, (int)x);
                if (GCD(a,x) != 1)
                {
					continue;
                }
				counter++;
				if (PowMod(a, x - 1, x) != 1)
					return false;
			} while (counter < 10);

			return true;
		}
		//Алгоритм Евклида для нахождения НОД
		static public uint GCD(uint a, uint b)
		{
			if (b == 0)
            {
				return a;
            }
			return GCD(b, a % b);
		}
        static public uint PowMod(UInt64 number, UInt64 index, UInt64 mod)
        {
			/*
			uint r = 1;
			while(y>0)
            {
                if (y%2 == 1)
                {
					r = (r * x) % n;
                }
				x = (x * x) % n;
				y >>= 1;
            }
			return r;
			*/
			if (index == 0)
				return 1;
			UInt64 res = 1;
            while (index > 0)
            {
				if (index % 2 == 1) res = checked(res * number) % mod;

				index /= 2;
				number = checked(number * number) % mod;
            }

			return (uint)res;
        }
        static public uint Extend_GCD(uint a, uint b)
        {
			uint
				Y1 = 1,
				Y0 = 0,
				X1 = 0,
				X0 = 1,
				r, q;
            while (b!=0)
            {
				uint tmp;
				r = a % b;
				a = b;
				b = r;
                if (b!=0)
				{
					q = a / b;
				}
                else
                {
					return X1;
                }
				tmp = Y0;
				Y0 = Y1 - q * Y0;
				Y1 = tmp;
				tmp = X0;
				X0 = X1 - q * X0;
				X1 = tmp;
            }
			return X1;
        }

		static public string RSAEncrypt(String ParentText, String eKey, String nKey)
        {
			UInt64 KeyE = Convert.ToUInt64(eKey);
			UInt64 KeyN = Convert.ToUInt64(nKey);

			String EncryptedText = "";
			for (int i = 0; i < ParentText.Length; i++)
            {
				UInt64 m = Convert.ToUInt64(ParentText[i]);
				uint c = (PowMod(m, KeyE, KeyN));
				EncryptedText += c.ToString() + " ";
            }
			return EncryptedText;
        }

		static public string RSADecrypt(String CipherText, String dKey, String nKey)
		{
			UInt64 KeyD = Convert.ToUInt64(dKey);
			UInt64 KeyN = Convert.ToUInt64(nKey);

			String PlainText = "";
			String[] ArrayNumbers = CipherText.TrimEnd().Split(' ');
			
			for (int i = 0; i < ArrayNumbers.Length; i++)
			{
				UInt64 c = Convert.ToUInt64(ArrayNumbers[i]);
				uint m = (PowMod(c, KeyD, KeyN));
				PlainText += Convert.ToChar(m);
			}
			return PlainText;
		}
	}
}
