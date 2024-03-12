using System;

namespace Atividade2.Entities
{
    public class Data
    {
        private readonly int _dia;
        private readonly int _mes;
        private readonly int _ano;
        private readonly int _hora;
        private readonly int _minuto;
        private readonly int _segundo;
        public const int FORMATO_12H = 12;
        public const int FORMATO_24H = 24;

        public Data(int dia, int mes, int ano)
        {
            _dia = dia;
            _mes = mes;
            _ano = ano;
        }

        public Data(int dia, int mes, int ano, int hora, int minuto, int segundo) : this(dia, mes, ano)
        {
            if (hora < 0 || hora > 23)
            {
                throw new ArgumentException("A hora fornecida deve estar entre 0 e 23.", nameof(hora));
            }

            _hora = hora;
            _minuto = minuto;
            _segundo = segundo;
        }

        public void Imprimir(int formato){
            string formatoHora = formato == FORMATO_12H ? "hh:mm:ss tt" : "HH:mm:ss";
            string dataHoraFormatada = $"{_dia}/{_mes}/{_ano} ";

            if (_hora != 0 || _minuto != 0 || _segundo != 0)
            {
                dataHoraFormatada += new DateTime(_ano, _mes, _dia, _hora, _minuto, _segundo).ToString(formatoHora);
            }
            Console.WriteLine(dataHoraFormatada); 
        }
    }
}
