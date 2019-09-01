using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knack.NET
{
    public interface IApiSettings
    {
        string AppId { get; }
        string ApiKey { get; }
        string BaseUrl { get; }
    }
}
