using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			int sequenceNumber = Convert.ToInt32(Console.ReadLine());
			List<int> list = new List<int>();

			while (sequenceNumber>=1)
			{
				if (sequenceNumber == 1)
				{
					Console.WriteLine(1);
					sequenceNumber = Convert.ToInt32(Console.ReadLine());
				}

				else if(sequenceNumber>1)
				{
					while (sequenceNumber>=1)
					{
						if (sequenceNumber == 1)
						{
							list.Add(sequenceNumber);
						}

						else if (sequenceNumber % 2 == 0)
						{
							list.Add(sequenceNumber);
							sequenceNumber = sequenceNumber / 2;

						}
						else if (sequenceNumber % 2 != 0)
						{
							list.Add(sequenceNumber);
							sequenceNumber = sequenceNumber * 3 + 1;

						}
					}

					list.ForEach(Console.WriteLine);
					foreach (int i in list)
					{
						Console.Write(i + " ");

					}
				}//else

				sequenceNumber = Convert.ToInt32(Console.ReadLine());


			}    //while--sequence number

			

		}//main



	}
}