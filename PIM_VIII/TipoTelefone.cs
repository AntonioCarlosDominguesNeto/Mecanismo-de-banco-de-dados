namespace PIM_VIII
{
    public class TipoTelefone
    {
        //Atributos
        protected string id;
        public string tipo;

        //Getters e Setters
        public string i
        {
            get{
                return id;
                int.Parse(id);
            }

            set{
                id = value;
                int.Parse(id);
            }
        }
    }
}