using SNT_WEB.Domain.Entities;
using System;
using System.Linq;

namespace SNT_WEB.Domain.Repositories.Abstract
{
    public interface ITextFieldRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldCodeWord(string codeWord);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}
