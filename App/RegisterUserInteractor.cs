using Domainmodel;

namespace App
{
    public class RegisterUserInteractor : IRegisterUserRequestInterface
    {
        public RegisterUserRequestModel RequestModel { get; set; }
        public RegisterUserResponsModel ResponsModel { get; set; }
        public Club Club { get; }
        public IRegisterUserResponsInterface Respons;

        public RegisterUserInteractor(Club club)
        {
            RequestModel = new RegisterUserRequestModel();
            ResponsModel = new RegisterUserResponsModel();
            Club = club;
        }


        //https://stackoverflow.com/questions/70913826/clean-architecture-can-the-preseter-talk-to-to-the-controller

        public void RegisterNewUser()
        {
            if(RequestModel.Username != null)
            {
                User user = new User(RequestModel.Username);
                try
                {
                    Club.RegisterUser(user);
                }
                catch
                {
                    ResponsModel.Msg = "User already exists";
                }
                ResponsModel.Msg = "User succesfull registert";
            }           
        }
    }
}