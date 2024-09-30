using System.IO;

	    Console.Clear();
		int largura = 50; // Ajuste a largura do cabeçalho conforme necessário
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("=".PadLeft(37, '='));
		Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
		Console.WriteLine("=".PadLeft(37, '='));
		Console.ResetColor();
		Random random = new Random();
		bool repetir = false;
		Console.Write("Deseja realizar quantos jogos: ");
		if (int.TryParse(Console.ReadLine(), out int qtdJogoInformada))
		{
			do
			{
				Console.Write("Informar a quantidade de dezena: ");
				if (int.TryParse(Console.ReadLine(), out  int qtdDezenaInformada))
				{
					if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
					{
						repetir = true;
					}
					else
					{
						repetir = false;
					}

					if (repetir == false)
					{
						for (int qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
						{
							for (int qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
							{
								int valores = random.Next(01, 60);
								if (qtdDezena == qtdDezenaInformada)
								{
									Console.Write($"{valores:D2}");
								}
								else
								{
									Console.Write($"{valores:D2}-");
								}
							}
						}

						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine("Jogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
						Console.ResetColor();
					}
					else
					{
						Console.WriteLine("Quantidade dezena menor que 6");
						repetir = true;
					}
				}
				else
				{
					repetir = true;
					Console.WriteLine("Número inválido!");
				}
			}
			while (repetir == true);
		}
		else
		{
			Console.WriteLine("Número inválido!");
		}

		// Solicitar o valor do prêmio
		Console.Write("Informe o valor do prêmio: ");
		if (decimal.TryParse(Console.ReadLine(), out decimal valorPremio))
		{
			Console.WriteLine($"\n\nParabens a quem acertou 6 dezenas! Seu premio e de R$ {valorPremio * 0.75m}!\n");
			Console.WriteLine($"Parabens a quem acertou 5 dezenas! Seu premio e de R$ {valorPremio * 0.15m}\n");
			Console.WriteLine($"Parabens a quem acertou 4 dezenas! Seu premio e de R$ {valorPremio * 0.10m}\n");
		}
		else
		{
			Console.WriteLine("Numero invalido!");
		}