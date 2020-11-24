using HealthyAndHappy.Models.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Services.Interfaces
{
    interface IMessageService
    {
        ResponseDTO addMessage(MessageDTO messageDTO);
        ResponseDTO deleteMessage(string mail);
        MessagesDTO getAllMessages();
        MessagesDTO getMessagesByUser(string userId);
        MessagesDTO getNextPage(int pageNumber);
    }
}
