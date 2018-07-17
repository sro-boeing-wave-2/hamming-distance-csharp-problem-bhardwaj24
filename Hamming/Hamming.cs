using System;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
            int hammingDistance = 0;
            int i;


            if (original == null)
            {
                throw new System.ArgumentNullException("original");
            }
            else if (current == null)
            {
                throw new System.ArgumentNullException("current");
            }
            else
            {
                int original_length = original.Length;
                int current_length = current.Length;
                if (original_length == 0 && current_length == 0)
                {
                    hammingDistance = 0;
                }
                else if (original_length > current_length)
                {
                    throw new System.ArgumentException("Hamming Distance can only be calculated over strings of equal length");

                }
                else if (original_length < current_length)
                {
                    throw new System.ArgumentException("Hamming Distance can only be calculated over strings of equal length");
                }
                else if (original_length == current_length)
                {
                    for (i = 0; i < original.Length; i++)
                    {
                        if (original[i] != current[i])
                        {
                            hammingDistance++;
                        }
                    }
                }
            }

            return hammingDistance;
        }
    }
}
