using System;

namespace Salvus
{
    public interface CometChatFormCallback
    {
        void SuccessCallback(String username);
        void FailCallback(String jSONObject);
    }
}
