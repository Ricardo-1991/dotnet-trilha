using Atividade2.Entities;

Data d1 = new(10, 03, 2000, 10, 30, 10);

d1.Imprimir(Data.FORMATO_12H);
d1.Imprimir(Data.FORMATO_24H);

Data d2 = new(5, 10,2005);

d2.Imprimir(Data.FORMATO_12H);
d2.Imprimir(Data.FORMATO_24H);
