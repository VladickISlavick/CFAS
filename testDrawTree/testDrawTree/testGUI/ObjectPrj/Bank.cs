namespace testGUI.ObjectPrj {
    public class Bank {
        public float precent;
        public float dateAvr;//���� ������ �������
        public float money;

        public Bank()
            : this(28, 3, 500) {
        }

        public Bank(float procent, float dateAvr, float money) {
            this.precent = procent;
            this.dateAvr = dateAvr;
            this.money = money;
        }

        public override string ToString() {
            return $"����� ������ � ������ {money}\n���� ������� ������� {dateAvr}\n������� ������� {precent}";
        }
    }
}