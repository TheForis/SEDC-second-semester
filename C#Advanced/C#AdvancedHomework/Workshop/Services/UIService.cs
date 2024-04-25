using Models;
using Storage;

namespace Services
{
    public class UIService
    {
        private UserHelper _userHelper;
        private ActiveTraining _train;
        public UIService()
        {
            _userHelper = new UserHelper();
            _train = new ActiveTraining();
        }

        public void RunProgram()
        {
            while (true)
            {
                try
                {
                    Console.Write("Please enter username or enter \"Register\" to sign up: ");
                    string userInput = Console.ReadLine();
                    if (userInput.ToLower() == "register")
                    {
                        _userHelper.Register();
                    }
                    else
                    {
                        _userHelper.Login(userInput);
                        break;
                    }

                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public void TrainerMenu()
        {
            bool stayLoggedIn = true;
            while (stayLoggedIn)
            {
                Console.WriteLine($"Please choose below \n1) Schedule live training \n2) Reschedule training \n3) Train \n4) Account \n5) Logout");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CreateTraining();
                        break;
                    case "2":
                        ModifyTraining();
                        break;
                    case "3":
                        _train.TrainNow();
                        break;
                    case "4":
                        AccountInfo();
                        break;
                    case "5":
                        CurrentSession.LoggedIn = null;
                        stayLoggedIn = false;
                        Console.Clear() ;
                        break;
                    default:
                        Console.WriteLine("Please enter from the given choices!");
                        break;


                }

            }
        }
        public void UserMenu()
        {
            bool stayLoggedIn = true;
            User loggedInUser = (User)CurrentSession.LoggedIn;
            while (stayLoggedIn)
            {
                if (loggedInUser.IsPremium == true)
                {
                    stayLoggedIn = PremiumUser(loggedInUser);
                    continue;

                }
                if (loggedInUser.IsPremium == false)
                {
                    stayLoggedIn = StandardUser(loggedInUser);
                    continue;
                }
                else
                {
                    throw new Exception("There was and error. Please try again.");
                }
            }
        }
        public bool StandardUser(User loggedInUser)
        {
            Console.WriteLine("Please choose from the options below \n1) Train \n2) Upgrade to premium \n3) Account \n4) Log out");
            switch (Console.ReadLine())
            {
                case "1":
                    _train.TrainNow();
                    return true;
                case "2":
                    loggedInUser.GetPremium();
                    return true;
                case "3":
                    AccountInfo();
                    return true;
                case "4":
                    CurrentSession.LoggedIn = null;
                    Console.Clear();
                    return false;
                default:
                    Console.WriteLine("Please enter from the given choices!");
                    return true;

            }
        }
        public bool PremiumUser(User loggedInUser)
        {
            Console.WriteLine("Please choose from the options below \n1) Train \n2) Check when is the next live training \n3) Account \n4) Log out");
            switch (Console.ReadLine())
            {
                case "1":
                    _train.TrainNow();
                    loggedInUser.RemovePremium();
                    return true;
                case "2":
                    CheckNextTraining();
                    return true;
                case "3":
                    AccountInfo();
                    return true;
                case "4":
                    CurrentSession.LoggedIn = null;
                    Console.Clear();
                    return false;
                default:
                    Console.WriteLine("Please enter from the given choices!");
                    return true;

            }
        }
        public void CheckNextTraining()
        {
            var today = DateTime.Now;
            var trainingList = StorageSpace.LiveTrainings.SelectMany(x => x.Value).ToList();
            var nextTraining = trainingList.Where(x => x.Date >= today).OrderBy(x => (x - today).Ticks).FirstOrDefault();
            Console.WriteLine($"The next live training is on {nextTraining.DayOfWeek}. [ {nextTraining} ]");

        }
        public void CreateTraining()
        {
            try
            {
                Console.Write("Enter the date and the time of the training[dd-mm-yyyy hh-mm]: ");
                string newTrainingDate = Console.ReadLine();
                if (DateTime.TryParse(newTrainingDate, out DateTime dateResult))
                {
                    Console.WriteLine($"Training created! [ {dateResult} ]");
                    if (!StorageSpace.LiveTrainings.TryGetValue(CurrentSession.LoggedIn, out List<DateTime> trainingsList))
                    {
                        trainingsList = new List<DateTime>();
                        StorageSpace.LiveTrainings.Add(CurrentSession.LoggedIn, trainingsList);
                        trainingsList.Add(dateResult);
                    }
                    else
                    {

                        trainingsList.Add(dateResult);
                    }

                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter valid date and time!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ModifyTraining()
        {
            Console.WriteLine("Please select the training you want to reschedule.");
            var loggedInTrainings = StorageSpace.LiveTrainings.FirstOrDefault(x => x.Key == CurrentSession.LoggedIn).Value;
            for (int i = 0; i < loggedInTrainings.Count; i++)
            {
                Console.WriteLine($"{i}: [{loggedInTrainings[i]}]");
            }
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int parsedUserInput))
            {
                if (parsedUserInput > loggedInTrainings.Count || userInput == null)
                {
                    Console.WriteLine($"Please choose between 0 - {loggedInTrainings.Count}");
                    return;
                }
                else
                {
                    var trainingList = StorageSpace.LiveTrainings.GetValueOrDefault(CurrentSession.LoggedIn);
                    trainingList.RemoveAt(parsedUserInput);
                    CreateTraining();
                }
            }
        }
        public void AccountInfo()
        {
            if (CurrentSession.LoggedIn == null)
            {
                throw new Exception("Session closed. Please log In again!");
            }
            if (CurrentSession.LoggedIn.Role == RoleEnum.Trainer)
            {
                Console.WriteLine($"Currently logged in {CurrentSession.LoggedIn.FullName()} with role {CurrentSession.LoggedIn.Role}.");
            }
            if (CurrentSession.LoggedIn.Role == RoleEnum.User)
            {
                var userLogged = (User)CurrentSession.LoggedIn;
                Console.WriteLine($"Currently logged in {CurrentSession.LoggedIn.FullName()} with role {CurrentSession.LoggedIn.Role}.  Premium account: {userLogged.IsPremium}");
            }


        }




    }
}
