﻿using BeFaster.Runner.Exceptions;
using System.Linq;
using System.Text.RegularExpressions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string skus)
        {
            System.Console.WriteLine("entry");
            int checkoutAmount = 0;
            if (string.IsNullOrEmpty(skus))
            {
                return 0;
            }
            if (!Regex.IsMatch(skus, @"^[A-Z]+$"))
            {
                return -1;
            }
            int A_count = skus.Count(v => v == 'A');
            int B_count = skus.Count(v => v == 'B');
            int C_count = skus.Count(v => v == 'C');
            int D_count = skus.Count(v => v == 'D');
            int E_count = skus.Count(v => v == 'E');
            int F_count = skus.Count(v => v == 'F');
            int G_count = skus.Count(v => v == 'G');
            int H_count = skus.Count(v => v == 'H');
            int I_count = skus.Count(v => v == 'I');
            int J_count = skus.Count(v => v == 'J');
            int K_count = skus.Count(v => v == 'K');
            int L_count = skus.Count(v => v == 'L');
            int M_count = skus.Count(v => v == 'M');
            int N_count = skus.Count(v => v == 'N');
            int O_count = skus.Count(v => v == 'O');
            int P_count = skus.Count(v => v == 'P');
            int Q_count = skus.Count(v => v == 'Q');
            int R_count = skus.Count(v => v == 'R');
            int S_count = skus.Count(v => v == 'S');
            int T_count = skus.Count(v => v == 'T');
            int U_count = skus.Count(v => v == 'U');
            int V_count = skus.Count(v => v == 'V');
            int W_count = skus.Count(v => v == 'W');
            int X_count = skus.Count(v => v == 'X');
            int Y_count = skus.Count(v => v == 'Y');
            int Z_count = skus.Count(v => v == 'Z');
            if (B_count >= (E_count / 2))
            {
                B_count = B_count - (E_count / 2);
            }
            if (F_count >= 3)
            {
                F_count = F_count - (F_count / 3);
            }
            if (M_count >= (N_count / 3))
            {
                M_count = M_count - (N_count / 3);
            }
            if (Q_count >= (R_count / 3))
            {
                Q_count = Q_count - (R_count / 3);
            }
            if (U_count >= 4)
            {
                U_count = U_count - (U_count / 4);
            }
            checkoutAmount = checkoutAmount + ((A_count / 5) * 200);
            checkoutAmount = checkoutAmount + (((A_count % 5) % 3) * 50);
            checkoutAmount = checkoutAmount + (((A_count % 5) / 3) * 130);
            checkoutAmount = checkoutAmount + ((B_count % 2) * 30);
            checkoutAmount = checkoutAmount + ((B_count / 2) * 45);
            checkoutAmount = checkoutAmount + (C_count * 20);
            checkoutAmount = checkoutAmount + (D_count * 15);
            checkoutAmount = checkoutAmount + (E_count * 40);
            checkoutAmount = checkoutAmount + (F_count * 10);

            checkoutAmount = checkoutAmount + (G_count * 20);
            checkoutAmount = checkoutAmount + ((H_count / 10) * 80);
            checkoutAmount = checkoutAmount + (((H_count % 10) % 5) * 10);
            checkoutAmount = checkoutAmount + (((H_count % 10) / 5) * 45);
            checkoutAmount = checkoutAmount + (I_count * 35);
            checkoutAmount = checkoutAmount + (J_count * 60);
            checkoutAmount = checkoutAmount + ((K_count % 2) * 70);
            checkoutAmount = checkoutAmount + ((K_count / 2) * 120);
            checkoutAmount = checkoutAmount + (L_count * 90);
            checkoutAmount = checkoutAmount + (M_count * 15);
            checkoutAmount = checkoutAmount + (N_count * 40);
            checkoutAmount = checkoutAmount + (O_count * 10);
            checkoutAmount = checkoutAmount + ((P_count % 5) * 50);
            checkoutAmount = checkoutAmount + ((P_count / 5) * 200);
            checkoutAmount = checkoutAmount + ((Q_count % 3) * 30);
            checkoutAmount = checkoutAmount + ((Q_count / 3) * 80);
            checkoutAmount = checkoutAmount + (R_count * 50);
            checkoutAmount = checkoutAmount + (U_count * 40);
            checkoutAmount = checkoutAmount + ((V_count / 3) * 130);
            checkoutAmount = checkoutAmount + (((V_count % 3) % 2) * 50);
            checkoutAmount = checkoutAmount + (((V_count % 3) / 2) * 90);
            checkoutAmount = checkoutAmount + (W_count * 20);
            int i = 0;
            int multibuyCount = 0;

            while (i == 0)
            {
                if (S_count > 1)
                {
                    multibuyCount++;
                    S_count--;
                }
                if (T_count > 1)
                {
                    multibuyCount++;
                    T_count--;
                }
                if (X_count > 1)
                {
                    multibuyCount++;
                    X_count--;
                }
                if (multibuyCount == 3)
                {
                    checkoutAmount = checkoutAmount + 45;
                    multibuyCount = 0;
                }
                if (Y_count > 1)
                {
                    multibuyCount++;
                }
                if (Z_count > 1)
                {
                    multibuyCount++;
                }
                //if (multibuyCount == 3)
                //{
                //    checkoutAmount = checkoutAmount + 45;
                //}
            }
            System.Console.WriteLine("after loop");
            checkoutAmount = checkoutAmount + (S_count * 20);
            checkoutAmount = checkoutAmount + (T_count * 20);
            checkoutAmount = checkoutAmount + (X_count * 17);
            checkoutAmount = checkoutAmount + (Y_count * 20);
            checkoutAmount = checkoutAmount + (Z_count * 21);
            System.Console.WriteLine("exit");
            return checkoutAmount;
        }
    }
}
