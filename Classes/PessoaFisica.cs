using BE5.Interfaces;

namespace BE5.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        public string ?cpf { get; set; }
        public DateTime ?dataNascimento { get; set; }
        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if (anos >= 18){
                return true;
            }
            else{
                return false;
            }
             
        }
    
        public bool ValidarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            //verificar se a string está em um formato válido.
            if (DateTime.TryParse(dataNasc, out dataConvertida)){// tryParse tenta converter e coloca na saida dataConvertida.
                //Console.WriteLine($"{dataConvertida}");
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays / 365;
                if (anos >= 18){
                    return true;
                }
                return false;
            }
            return false;
        }      
     }
}
