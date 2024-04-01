namespace exercise04.Models
{
    public static class DogHelper
    {
        public static bool Validate(Dog dog)
        {
            /*if ( dog.Id <= 0 ) return false;
            if(string.IsNullOrEmpty( dog.Name ) || dog.Name.Length < 2) return false;
            return true;*/

            return dog.Id > 0 && !string.IsNullOrEmpty(dog.Name) && dog.Name.Length >=2 ;
        }
    }
}
