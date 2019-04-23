using System;

namespace CombinaisonJeux
{
    public class Combinatoire
    {
        int SOMME_CIBLE;
        int CombinaisonN;
        int CombinaisonM;

        public Combinatoire(int somme_cible , int combinaisonN, int combinaisonM)
        {
            SOMME_CIBLE = somme_cible;
            CombinaisonN = combinaisonN;
            CombinaisonM = combinaisonM;
        }

        public ulong CalculCombinatoire()
        {
            int n = SOMME_CIBLE, m = 0, sommeCombinaison = 0; ulong result = 0;

            while (n >= 0 && m <= 13)
            {
                sommeCombinaison = (n * CombinaisonN) + (m * CombinaisonM);

                //Si la somme de n 1 et m 2 est 26 alors on applique la formule
                if (sommeCombinaison == SOMME_CIBLE)
                {
                    //Debug afficher les possibilités avec n et m
                    Console.WriteLine("Nombre d'occurence de premiere valeur ({0})={1} , Nombre d'occurence de deuxième valeur ({2})={3}", CombinaisonN,n , CombinaisonM, m);

                    result = result + CombinatoireAvecRepetition(n, m);
                }

                m++;
                n -= 2;
            }

            return result;
        }


        /// <summary>
        /// Combinatoire avec répétition
        /// </summary>
        /// <param name="n">premiere valeur de combibnaison</param>
        /// <param name="m">deuxième valeur de combibnaison </param>
        /// <returns>nombre Combinaisons Avec Repetition</returns>
        ulong CombinatoireAvecRepetition(int n, int m)
        {
            ulong nombreCombinaisonsAvecRepetition = Factorielle(n + m) / (Factorielle(n) * Factorielle(m));

            return nombreCombinaisonsAvecRepetition;
        }

        ulong Factorielle(int number)
        {
            ulong resultFactorielle = 1;

            for (int i = 1; i <= number; i++)
            {
                resultFactorielle = resultFactorielle * (ulong)i;
            }

            return resultFactorielle;
        }
    }
}
