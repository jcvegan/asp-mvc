namespace Sample1.Infrastructure.Views {
    //Vistas sin modelo asignado
    public abstract class MyView : System.Web.Mvc.WebViewPage {
        //Atributos
        private readonly string hello = "Hello World";

        //Propiedades
        public string Greeting {
            get {
                return hello;
            }
        }
    }

    //Vistas con modelo asignado
    public abstract class MyView<TModel> : System.Web.Mvc.WebViewPage<TModel> {
        //Atributos
        private readonly string hello = "Hello World";

        //Propiedades
        public string Greeting {
            get {
                return hello;
            }
        }
    }
}