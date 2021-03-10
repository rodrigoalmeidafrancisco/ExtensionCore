﻿using System;
using System.Text.RegularExpressions;

namespace ExtensionCore
{
    public static class BoolExtension
    {
        public static bool IsNullOrEmpty(this string val)
        {
            return string.IsNullOrEmpty(val);
        }

        public static bool IsNullOrWhiteSpace(this string val)
        {
            return string.IsNullOrWhiteSpace(val);
        }

        public static bool IsNullOrEmptyOrWhiteSpace(this string val)
        {
            return string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val);
        }

        public static bool IsBetween(this DateTime val, DateTime start, DateTime end)
        {
            return val >= start && val <= end;
        }

        public static bool IsBetween(this int val, int start, int end)
        {
            return val >= start && val <= end;
        }

        public static bool IsBetween(this long val, long start, long end)
        {
            return val >= start && val <= end;
        }

        public static bool IsBetween(this decimal val, decimal start, decimal end)
        {
            return val >= start && val <= end;
        }

        public static bool IsBetween(this float val, float start, float end)
        {
            return val >= start && val <= end;
        }

        public static bool IsBetween(this double val, double start, double end)
        {
            return val >= start && val <= end;
        }

        public static bool IsBetween(this TimeSpan val, TimeSpan start, TimeSpan end)
        {
            return val >= start && val <= end;
        }

        public static bool IsGreaterThan(this DateTime val, DateTime comparer)
        {
            return val > comparer;
        }

        public static bool IsGreaterThan(this int val, int comparer)
        {
            return val > comparer;
        }

        public static bool IsGreaterThan(this long val, long comparer)
        {
            return val > comparer;
        }

        public static bool IsGreaterThan(this decimal val, decimal comparer)
        {
            return val > comparer;
        }

        public static bool IsGreaterThan(this float val, float comparer)
        {
            return val > comparer;
        }

        public static bool IsGreaterThan(this double val, double comparer)
        {
            return val > comparer;
        }

        public static bool IsGreaterThan(this TimeSpan val, TimeSpan comparer)
        {
            return val > comparer;
        }

        public static bool IsLowerThan(this DateTime val, DateTime comparer)
        {
            return val < comparer;
        }

        public static bool IsLowerThan(this int val, int comparer)
        {
            return val < comparer;
        }

        public static bool IsLowerThan(this long val, long comparer)
        {
            return val < comparer;
        }

        public static bool IsLowerThan(this decimal val, decimal comparer)
        {
            return val < comparer;
        }

        public static bool IsLowerThan(this float val, float comparer)
        {
            return val < comparer;
        }

        public static bool IsLowerThan(this double val, double comparer)
        {
            return val < comparer;
        }

        public static bool IsLowerThan(this TimeSpan val, TimeSpan comparer)
        {
            return val < comparer;
        }

        public static bool StringOnlyNumbers(this string val)
        {
            var regex = new Regex(@"^[0-9]+$");

            if (!val.IsNullOrEmptyOrWhiteSpace())
            {
                return regex.IsMatch(val);
            }

            return false;
        }

        public static bool StringOnlyCharacters(string val)
        {
            var regex = new Regex(@"^([\'\.\^\~\´\`\\áÁ\\àÀ\\ãÃ\\âÂ\\éÉ\\èÈ\\êÊ\\íÍ\\ìÌ\\óÓ\\òÒ\\õÕ\\ôÔ\\úÚ\\ùÙ\\çÇaA-zZ]+)+((\s[\'\.\^\~\´\`\\áÁ\\àÀ\\ãÃ\\âÂ\\éÉ\\èÈ\\êÊ\\íÍ\\ìÌ\\óÓ\\òÒ\\õÕ\\ôÔ\\úÚ\\ùÙ\\çÇaA-zZ]+)+)?$");

            if (!val.IsNullOrEmptyOrWhiteSpace())
            {
                return regex.IsMatch(val);
            }

            return false;
        }

        public static bool ValidCPF(string val)
        {
            bool valueReturn = false;

            try
            {
                if (!val.IsNullOrEmptyOrWhiteSpace())
                {
                    var regex = new Regex(@"([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})");

                    if (regex.IsMatch(val))
                    {
                        int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                        int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                        string tempCpf;
                        string digito;
                        int soma;
                        int resto;

                        val = val.Trim();
                        val = val.Replace(".", "").Replace("-", "");
                        
                        if (val.Equals("00000000000") || val.Equals("11111111111") ||val.Equals("22222222222") || val.Equals("33333333333") ||
                            val.Equals("44444444444") || val.Equals("55555555555") || val.Equals("66666666666") || val.Equals("77777777777") ||
                            val.Equals("88888888888") || val.Equals("99999999999") || (val.Length != 11))
                        {
                            valueReturn = false;
                        }
                        else
                        {
                            tempCpf = val.Substring(0, 9);
                            soma = 0;

                            for (int i = 0; i < 9; i++)
                            {
                                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                            }

                            resto = soma % 11;
                            if (resto < 2)
                            {
                                resto = 0;
                            }
                            else
                            {
                                resto = 11 - resto;
                            }

                            digito = resto.ToString();
                            tempCpf = tempCpf + digito;
                            soma = 0;

                            for (int i = 0; i < 10; i++)
                            {
                                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                            }

                            resto = soma % 11;
                            if (resto < 2)
                            {
                                resto = 0;
                            }
                            else
                            {
                                resto = 11 - resto;
                            }

                            digito = digito + resto.ToString();
                            
                            if (val.EndsWith(digito))
                            {
                                valueReturn = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                valueReturn = false;
            }

            return valueReturn;
        }

        public static bool ValidCNPJ(string val)
        {
            bool valueReturn = false;
            
            try
            {
                if (!val.IsNullOrEmptyOrWhiteSpace())
                {
                    var regex = new Regex(@"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})");

                    if (regex.IsMatch(val))
                    {
                        Int32[] digitos, soma, resultado;
                        Int32 nrDig;
                        String ftmt;
                        Boolean[] valOk;

                        val = val.Replace("/", "");
                        val = val.Replace(".", "");
                        val = val.Replace("-", "");

                        if (val.Equals("00000000000000") || val.Equals("11111111111111") || val.Equals("22222222222222") || val.Equals("33333333333333") ||
                            val.Equals("44444444444444") || val.Equals("55555555555555") || val.Equals("66666666666666") || val.Equals("77777777777777") ||
                            val.Equals("88888888888888") || val.Equals("99999999999999") || (val.Length != 14))
                        {
                            valueReturn = false;
                        }
                        else
                        {
                            ftmt = "6543298765432";
                            digitos = new Int32[14];
                            soma = new Int32[2];
                            soma[0] = 0;
                            soma[1] = 0;
                            resultado = new Int32[2];
                            resultado[0] = 0;
                            resultado[1] = 0;
                            valOk = new Boolean[2];
                            valOk[0] = false;
                            valOk[1] = false;

                            for (nrDig = 0; nrDig < 14; nrDig++)
                            {
                                digitos[nrDig] = int.Parse(val.Substring(nrDig, 1));
                                if (nrDig <= 11)
                                {
                                    soma[0] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig + 1, 1)));
                                }
                                if (nrDig <= 12)
                                {
                                    soma[1] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig, 1)));
                                }
                            }

                            for (nrDig = 0; nrDig < 2; nrDig++)
                            {
                                resultado[nrDig] = (soma[nrDig] % 11);

                                if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))
                                {
                                    valOk[nrDig] = (digitos[12 + nrDig] == 0);
                                }
                                else
                                {
                                    valOk[nrDig] = (digitos[12 + nrDig] == (11 - resultado[nrDig]));
                                }
                            }

                            if (valOk[0] && valOk[1])
                            {
                                valueReturn = true;
                            }
                        }
                    }
                }
            }
            catch 
            {
                valueReturn = false;
            }

            return valueReturn;
        }

    }
}
