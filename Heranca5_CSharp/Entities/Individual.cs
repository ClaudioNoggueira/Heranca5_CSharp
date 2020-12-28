
namespace Entities {
    class Individual : TaxPayer {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome) {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax() {
            double tax = 0;
            if (AnualIncome < 20000) {
                tax = AnualIncome * 0.15;
            }
            else if (AnualIncome >= 20000) {
                tax = AnualIncome * 0.25;
            }

            if (HealthExpenditures != 0) {
                tax -= (HealthExpenditures / 2);
            }
            return tax;
        }
    }
}
