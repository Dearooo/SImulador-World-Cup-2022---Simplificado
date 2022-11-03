using System;
using Simulador_de_Mata_Mata_World_Cup_2022.Models;
using Simulador_de_Mata_Mata_World_Cup_2022.Models.Operacoes;

Time[] A = new Time[4];
Time Exemplo = new Time("hell");
A[0] = Exemplo.Cadastro("CATAR");
A[1] = Exemplo.Cadastro("EQUADOR");
A[2] = Exemplo.Cadastro("SENEGAL");
A[3] = Exemplo.Cadastro("HOLANDA");

Time[] B = new Time[4];
B[0] = Exemplo.Cadastro("INGLATERRA");
B[1] = Exemplo.Cadastro("IRÃ");
B[2] = Exemplo.Cadastro("ESTADOS UNIDOS");
B[3] = Exemplo.Cadastro("PAIS DE GALES");

Time[] C = new Time[4];
C[0] = Exemplo.Cadastro("ARGENTINA");
C[1] = Exemplo.Cadastro("ARABIA SAUDITA");
C[2] = Exemplo.Cadastro("MEXICO");
C[3] = Exemplo.Cadastro("POLONIA");

Time[] D = new Time[4];
D[0] = Exemplo.Cadastro("FRANÇA");
D[1] = Exemplo.Cadastro("AUSTRALIA");
D[2] = Exemplo.Cadastro("DINAMARCA");
D[3] = Exemplo.Cadastro("TUNISIA");

Time[] E = new Time[4];
E[0] = Exemplo.Cadastro("ESPANHA");
E[1] = Exemplo.Cadastro("COSTA RICA");
E[2] = Exemplo.Cadastro("ALEMANHA");
E[3] = Exemplo.Cadastro("JAPAO");

Time[] F = new Time[4];
F[0] = Exemplo.Cadastro("BELGICA");
F[1] = Exemplo.Cadastro("CANADA");
F[2] = Exemplo.Cadastro("MARROCOS");
F[3] = Exemplo.Cadastro("CROACIA");

Time[] G = new Time[4];
G[0] = Exemplo.Cadastro("BRASIL");
G[1] = Exemplo.Cadastro("SERVIA");
G[2] = Exemplo.Cadastro("SUIÇA");
G[3] = Exemplo.Cadastro("CAMAROES");

Time[] H = new Time[4];
H[0] = Exemplo.Cadastro("PORTUGAL");
H[1] = Exemplo.Cadastro("GANA");
H[2] = Exemplo.Cadastro("URUGUAI");
H[3] = Exemplo.Cadastro("COREIA DO SUL");

Operacoes.Controle_FG(A);
Operacoes.Controle_FG(B);
Operacoes.Controle_FG(C);
Operacoes.Controle_FG(D);
Operacoes.Controle_FG(E);
Operacoes.Controle_FG(F);
Operacoes.Controle_FG(G);
Operacoes.Controle_FG(H);

A = Operacoes.Selecao_quartas(A);
B = Operacoes.Selecao_quartas(B);
C = Operacoes.Selecao_quartas(C);
D = Operacoes.Selecao_quartas(D);
E = Operacoes.Selecao_quartas(E);
F = Operacoes.Selecao_quartas(F);
G = Operacoes.Selecao_quartas(G);
H = Operacoes.Selecao_quartas(H);

Time[] Time_Oitavas = new Time[8];

Console.Clear();
Console.WriteLine("Oitavas:Oitavas:Oitavas:Oitavas:Oitavas:");

Time_Oitavas[0] = Operacoes.Disputa_MM(A[0], B[1]);
Time_Oitavas[1] = Operacoes.Disputa_MM(C[0], D[1]);
Time_Oitavas[2] = Operacoes.Disputa_MM(B[0], A[1]);
Time_Oitavas[3] = Operacoes.Disputa_MM(D[0], C[1]);
Time_Oitavas[4] = Operacoes.Disputa_MM(E[0], F[1]);
Time_Oitavas[5] = Operacoes.Disputa_MM(G[0], H[1]);
Time_Oitavas[6] = Operacoes.Disputa_MM(F[0], E[1]);
Time_Oitavas[7] = Operacoes.Disputa_MM(H[0], G[1]);

Time[] Time_Quartas = new Time[4];

Console.Clear();
Console.WriteLine("Quartas:Quartas:Quartas:Quartas:Quartas:Quartas:");

Time_Quartas[0] = Operacoes.Disputa_MM(Time_Oitavas[0],Time_Oitavas[1]);
Time_Quartas[1] = Operacoes.Disputa_MM(Time_Oitavas[4],Time_Oitavas[5]);
Time_Quartas[2] = Operacoes.Disputa_MM(Time_Oitavas[2],Time_Oitavas[3]);
Time_Quartas[3] = Operacoes.Disputa_MM(Time_Oitavas[6],Time_Oitavas[7]);

Time[] Semifinais = new Time[2];

Console.Clear();
Console.WriteLine("SEMI:SEMI:SEMI:SEMI:SEMI:SEMI:SEMI:SEMI:SEMI:SEMI:");

Semifinais[0] = Operacoes.Disputa_MM(Time_Quartas[0], Time_Quartas[1]);
Semifinais[0] = Operacoes.Disputa_MM(Time_Quartas[2], Time_Quartas[3]);

Time Campeao = new Time("CAmpeao");

Console.Clear();
Campeao = Operacoes.Disputa_MM(Semifinais[0], Semifinais[1]);

Console.WriteLine("\t\tCongratulations!!!!!\n" + "\t\tO Campeão foi " + Campeao.name);
