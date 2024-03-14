using System.Globalization;

namespace C_Introduction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Task1
			//Bir integer arrayi yaradın, daha sonra istifadəçidən yaşını soruşun,
			//əgər istifadəçinin yaşı bu arrayda varsa true əks halda false çap edin

			int[] arr = { 18, 19, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };
			Console.WriteLine("Yasinizi daxil edin");
		    check:
			bool age = int.TryParse(Console.ReadLine(), out int num);
			if (!age)
			{
				Console.WriteLine("Duzgun daxil edin:");
				goto check;
			}
			foreach (var i in arr)
			{
				if (num == i)
				{
					age = true;
					break;
				}
				else
				{
					age = false;
				}
			}
			Console.WriteLine(age);
			#endregion

			#region Task2
			// Bir a yararraydın, bu massivdə sinifdəki tələbələrin adlarını saxlasın. Sonra, istifadəçidən bir tələbə adı daxil etməsini istəyin.
			// Əgər daxil edilən ad array-də varsa, "Tələbənin adını" çap edin, əks halda "Bu "Adda" Tələbə tapılmadı!" çap edin.

			string[] name = { "Ali", "Aydin", "Nigar", "Murad", "Hamid", "Jala", "Narmin" };
			Console.WriteLine("Adi daxil edin: ");
			string name1 = Console.ReadLine();
			string text = "";

			foreach (var item in name)
			{
				if (name1.ToLower() == item.ToLower())
				{
				    text= item;
					break;
				}
				else
				{
					text = "Bele adda telebe yoxdur";
				}
			}
			Console.WriteLine(text);
            #endregion
        }
	}
}