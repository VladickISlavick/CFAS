using System.Collections;

namespace testGUI.OldObject {
    public class Company {
        public float countProduct;
        public float[] changes;//�����������
        public float minPrice;
        public float srPrice;
        public float maxPrice;

        public bool WTF {
            get {
                float temp = 0;
                foreach (var item in changes) temp += item;
                return temp == 1;
            }
        }

        public Company()
            : this(300,  
                new float[]{
                    0.22f, 0.36f, 0.42f
                }, 
                1.51f, 1.8f, 2) {
        }

        public Company(float countProduct, float[] changes, float minPrice, float srPrice, float maxPrice) {
            this.countProduct = countProduct;
            this.changes = changes;
            Sort();
            this.minPrice = minPrice;
            this.srPrice = srPrice;
            this.maxPrice = maxPrice;
        }

        private void Sort() {
            for (int j = 0; j < changes.Length; j++){
                for (int i = 0; i < changes.Length - 1; i++) {
                    if (changes[i] > changes[i + 1]) {
                        var t = changes[i];
                        changes[i] = changes[i + 1];
                        changes[i + 1] = t;
                    }
                }
            }
        }

        public override string ToString() {
            return $"���������� ��������� {countProduct}\n����������� ���� {changes[0]}\n������� ���� {changes[1]}\n������������ ���� {changes[2]}\n����������� ���� {minPrice}\n������� ���� {srPrice}\n������������ ���� {maxPrice}";
        }
    }
}