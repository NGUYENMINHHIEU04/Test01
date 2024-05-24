using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    public class Mymath
    {
        // cong viec cua lap trinh vien 
        public static double Sumnumber(double a, double b)
        {
            return a + b;
        }
        // kiem tra nam nhuan DL
        public static bool CheckingLeapYear(int year)
        {
           if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
           {
                return true;
           }
           return false;    
        }


        
        public static bool KiemTraDoDaiTamGiac(double a , double b , double c) 
        {
            if (((a + b) > c) && ((b + c) > a) && ((c + a) > b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool KiemTraTamGiacVuong( double a , double b , double c)
        {
            if (KiemTraDoDaiTamGiac(a, b, c) && (a * a + b * b == c * c || b * b + c * c == a * a || a * a + c * c == b * b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Viet chuong trinh tinh TBC cac so nguyen to trong mot khoang cho trc 30 - 150 
        // tinh tong cac so nguyen to 
        // den slg cac so nguyen to
        // tinh trung binh cong
        public static bool CheckingSNT(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static double TinhTongSNT(int i , int j)
        {
            //tinh tong cac so nguyen to chay tu i-j 
            double sum = 0;
            for (int k = i; k <= j; k++)
            {
                if (CheckingSNT(k))
                {
                    sum += k; // sum = sum + k 
                }
            }
            return sum;
        }
        public static double DemSNT(int i , int j)
        {
            double count = 0;
            for (int k = i; k <= j ; k++ )
            {
                if (CheckingSNT(k))
                {
                    count++; // count+=1 
                }
            }
            return count;
        }
        public static double TinhTBCSNT(int i, int j)
        {
            double sum = TinhTongSNT (i, j);    
            double count = DemSNT (i, j);   
            return sum / count;
        }

        // giai phuong trinh bac nhat y = ax +b 
        public static double GiaiPTBN(double a, double b)
        {
            if (a ==0 )
            {
                if (b==0)
                {
                    return 0.0;
                }
                return 0;
            }
            return -b / a;
        }
    }
}
