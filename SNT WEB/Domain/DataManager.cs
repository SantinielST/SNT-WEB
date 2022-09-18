using SNT_WEB.Domain.Repositories.Abstract;

namespace SNT_WEB.Domain
{
    public class DataManager
    {
        public ITextFieldRepository TextField { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFieldRepository textFieldRepository, IServiceItemsRepository serviceItemsRepository)
        {
            TextField = textFieldRepository;
            ServiceItems = serviceItemsRepository;
        }
    }
}
