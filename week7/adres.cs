namespace week7 {
    public struct Adres {
        private string straat;
        private int huisnummer;
        private string postbus;

        private Postcode Postcode;
        

        public Adres(string straat, int nummer, int Postcode, string box){
            this.huisnummer = nummer;
            this.straat = straat;
            this.postbus = box;
          

        }
    }
}