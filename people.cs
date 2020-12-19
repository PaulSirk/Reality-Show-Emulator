using System;

namespace people
{
    public sealed class people
    {
        private string firstName;
        private string lastName;
        private int contestantId;
        private int placement;

        public people() {
            this.firstName = "?";
            this.lastName = "?";
            this.contestantId = -1;
            this.placement = 0;
        }

        public people(string first, string last, int id) {
            this.firstName = first;
            this.lastName = last;
            this.contestantId = id;
            this.placement = 0;
        }

        public string getFullName() {
            return firstName + " " + lastName;
        }

        public void setPlacement(int num) {
            this.placement = num;
        }

        public int getId(){
            return contestantId;
        }
    }
}
