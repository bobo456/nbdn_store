using System.Collections;
using System.Collections.Generic;
using nothinbutdotnetstore.web.application;

namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubFakeCommandSet : IEnumerable<WebCommand>
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<WebCommand> GetEnumerator()
        {

            yield return new DefaultWebCommand(x => true,
                                               new ViewMainDepartments());
            yield return new DefaultWebCommand(x => true,
                                               new ViewSubDepartments());
            yield return new DefaultWebCommand(x => true,
                                               new ViewProducts());
        }
    }
}