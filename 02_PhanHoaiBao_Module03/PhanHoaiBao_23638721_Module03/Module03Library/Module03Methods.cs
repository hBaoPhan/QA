using System;

namespace Module03Library
{
    public class Module03Methods
    {
        // Bài 1: getPositionOf2Cir
        public int getPositionOf2Cir(int firstRadius, int secRadius, int distance)
        {
            if (distance == 0)
            {
                if (firstRadius == secRadius)
                    return 0;
                else if (firstRadius < secRadius)
                    return 1;
                else
                    return 2;
            }
            if (distance > 0)
                return 3;
            return -1;
        }

        // Bài 2: CheckXYZ
        public char CheckXYZ(int X, int Y, int Z)
        {
            if (X == 1 || X == 2)
                return 'A';
            else
            {
                if (Y <= 10)
                    return 'B';
                else
                {
                    if (Z < 5)
                        return 'C';
                    else
                        return 'D';
                }
            }
        }

        // Bài 3: MaxAndMean
        public int MaxAndMean(int A, int B, int C, out double Mean)
        {
            Mean = (A + B + C) / 3.0;
            int Maximum;
            if (A > B)
            {
                if (A > C)
                    Maximum = A;
                else
                    Maximum = B; // Theo đúng đặc tả mã đề bài dòng 9
            }
            else
            {
                if (B > C)
                    Maximum = B;
                else
                    Maximum = C;
            }
            return Maximum;
        }

        // Bài 4: Max
        public int Max(int a, int b, int c)
        {
            int max = 0;
            if (a > 0 && b > 0 && c > 0)
                max = a;
            else
                return 0;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            return max;
        }

        // Bài 5: Triangle
        public string Triangle(int a, int b, int c)
        {
            int match = 0;
            if (a == b)
                match = match + 1;
            if (a == c)
                match = match + 2;
            if (b == c)
                match = match + 3;

            if (match == 0)
            {
                if ((a + b) <= c)
                    return "Not a Triangle";
                else if ((b + c) <= a)
                    return "Not a Triangle";
                else if ((a + c) <= b)
                    return "Not a Triangle";
                else
                    return "Triangle is Scalene";
            }
            else if (match == 1)
            {
                if ((a + c) <= b)
                    return "Not a Triangle";
                else
                    return "Triangle is Isosceles";
            }
            else if (match == 2)
            {
                if ((a + c) <= b)
                    return "Not a Triangle";
                else
                    return "Triangle is Isosceles";
            }
            else if (match == 3)
            {
                if ((b + c) <= a)
                    return "Not a Triangle";
                else
                    return "Triangle is Isosceles";
            }
            else
            {
                return "Triangle is Equilateral";
            }
        }

        // Bài 6: Average
        public double Average(double Sum, double Count)
        {
            if (Count == 1) return Sum;
            else if (Count > 0) return Sum / Count;
            else return 0;
        }

        // Bài 7: DaysInMonth
        public byte DaysInMonth(ushort Year, byte Month)
        {
            switch (Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (Year % 400 == 0)
                        return 29;
                    else if (Year % 100 == 0)
                        return 28;
                    else if (Year % 4 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 0; // Error, invalid month
            }
        }

        // Bài 8: SolveQuadratic
        public string SolveQuadratic(double a, double b, double c)
        {
            if (a == 0)
                return "Khong phai pt";
            double delta = b * b - 4 * a * c;
            if (delta < 0)
                return "PT vô nghiệm";
            if (delta == 0)
            {
                double x = -b / (2 * a);
                return x.ToString("F2");
            }
            else
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                return $"{x1:F2},{x2:F2}";
            }
        }

        // Bài 9: IsTriangle
        public bool IsTriangle(float a, float b, float c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return false;
            if (a + b <= c)
                return false;
            if (a + c <= b)
                return false;
            if (b + c <= a)
                return false;
            return true;
        }

        // Bài 10: CalculateBill
        public float CalculateBill(float total, float p1, float p2, float p3)
        {
            if (p1 < 0 || p2 < 0 || p3 < 0 || total < 0)
                throw new ArgumentException("Input values must be non-negative");
            if (total <= 100)
                return total * p1;
            else if (total <= 150)
                return 100 * p1 + (total - 100) * p2;
            else
                return 100 * p1 + 50 * p2 + (total - 150) * p3;
        }

        // Bài 11: IsPointInRectangle
        public bool IsPointInRectangle(float x1, float y1, float x2, float y2, float x, float y)
        {
            if (x1 > x2 || y1 > y2)
                throw new ArgumentException("print error: invalid rectangle boundaries");
            if (x < x1 || x > x2)
                return false;
            if (y < y1 || y > y2)
                return false;
            return true;
        }

        // Bài 12: IsLeapYear
        public bool IsLeapYear(int year)
        {
            if (year > 10000 || year < 1000)
                return false;
            else
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        return true;
                    else
                        return false;
                }
                else if (year % 4 == 0)
                    return true;
                else
                    return false;
            }
        }

        // Bài 13: PasswordCheck
        public bool PasswordCheck(string pass)
        {
            if (string.IsNullOrEmpty(pass))
                return false;
            if (pass.Length < 6)
                return false;
            if (pass.Length > 10)
                return false;
            bool hasDigit = false;
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsDigit(pass[i]))
                {
                    hasDigit = true;
                    break;
                }
            }
            return hasDigit;
        }

        // Bài 14: IsValidDate
        public bool IsValidDate(short Year, byte Month, byte Day)
        {
            if (Month < 1 || Month > 12)
                return false;
            if (Day < 1)
                return false;
            if (Day > DaysInMonth((ushort)Year, Month))
                return false;
            return true;
        }

        // Bài 15: EmailCheck
        public bool EmailCheck(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;
            if (!email.Contains("."))
                return false;
            if (email.Contains(".."))
                return false;
            int countAt = 0;
            foreach (char c in email)
            {
                if (c == '@') countAt++;
            }
            if (countAt != 1)
                return false;
            if (email.Contains("@.") || email.Contains(".@") || email.Contains("@@"))
                return false;
            return true;
        }

        // Bài 16: BodyCheck
        public sbyte BodyCheck(short height, int weight)
        {
            if (height <= 0)
                return -1;
            if (weight <= 0)
                return -1;
            int scale = weight * 10000 / (height * height);
            if (scale < 18)
                return 2;
            if (scale > 20)
                return 1;
            return 0;
        }

        // Bài 17: isInString
        public const int MAX_INT = 32767;

        public int IsInString(char tmp, string str = "statement coverage")
        {
            int pos = MAX_INT;
            int i = 0;
            if (str != null)
            {
                while (i < str.Length && str[i] != '\0')
                {
                    if (str[i] == tmp)
                    {
                        pos = i;
                        break;
                    }
                    i++;
                }
            }
            return pos;
        }

        // Bài 18: HexToDec
        public long HexToDec(string? hexaString)
        {
            if (hexaString == null)
                return 0;

            int c;
            long hexnum = 0, nhex = 0;
            int i = 0;
            while (i < hexaString.Length)
            {
                c = hexaString[i++];
                switch (c)
                {
                    case '0': case '1': case '2':
                    case '3': case '4': case '5':
                    case '6': case '7': case '8':
                    case '9':
                        /* Convert a decimal digit */
                        nhex++;
                        hexnum *= 0x10;
                        hexnum += (c - '0');
                        break;
                    case 'a': case 'b': case 'c':
                    case 'd': case 'e': case 'f':
                        /* lower case hex digit */
                        nhex++;
                        hexnum *= 0x10;
                        hexnum += (c - 'a' + 0xa);
                        break;
                    case 'A': case 'B': case 'C':
                    case 'D': case 'E': case 'F':
                        /* upper case hex digit */
                        nhex++;
                        hexnum *= 0x10;
                        hexnum += (c - 'A' + 0xA);
                        break;
                    default:
                        /* non-hex characters */
                        break;
                }
            }
            return hexnum;
        }
    }
}
