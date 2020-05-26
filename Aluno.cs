namespace CadastroAluno
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista;
        public float percentualBolsa;
        public float mediaFinal;
        public float valorMensalidade;


        /// <summary>
        /// Mostra a média final do aluno
        /// </summary>
        /// <returns>Média final (float)</returns>
        public float VerMediaFinal(){
            return mediaFinal;
        }
         
         /// <summary>
         /// Calcular mensalidade de acordo com a bolsa disponível
         /// </summary>
         /// <returns>Valor da mensalidade a ser paga</returns>
        public float VerMensalidade(){

            float calculo = valorMensalidade;

            if(bolsista == true){
                calculo = valorMensalidade - (valorMensalidade * percentualBolsa / 100);
            }

            return calculo;
        }
        /// <summary>
        /// Aprimora a resposta do usuario
        /// </summary>
        /// <param name="condicao">Texto capiturado pelo console</param>
        /// <returns>Retorna se é bolsista ou não</returns>
        public bool TraduzConsole(string condicao){
            if(condicao == "sim"){
                bolsista = true;
                
            }else{
                bolsista = false;
            }

            return bolsista;
        }
    }
}