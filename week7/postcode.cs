namespace week7 

{

    public struct Postcode{
        private int postcode;
        private string provincie;
        private string gemeente;
        private bool isDeelgemeente;


        public Postcode(string gemeente, int postcode) : this(gemeente, false, postcode, "onbekend")
        {
            //this.postcode = postcode;  //zal niet werken met de eerste 2 lijnen
            //this.gemeente = gemeente;
            //this.isDeelgemeente = false; //default waarde
            //this.provincie = "onbekend";
        }

        public Postcode(string gemeente, bool isDeelgemeente, int postcode, string provincie)
        {
            this.postcode = postcode;
            this.gemeente = gemeente;
            this.isDeelgemeente = false; //default waarde
            this.provincie = "onbekend";
        }
    }

}