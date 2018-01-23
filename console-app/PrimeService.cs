public class PrimeService
{
        public bool IsPrime(int number){
            if(number == 1 ) return false;
            if(number % 2 == 0 ) return false;
            if(number > 3 && number % 3 == 0 ) return false;
            else return true;
        }
}