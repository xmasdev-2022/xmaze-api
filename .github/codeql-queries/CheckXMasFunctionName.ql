/**
 * @name Check XMas Function Name
 * @id check-xmas-function-name
 * @kind problem
 * @problem.severity error
 */

import csharp

from Attribute attribute, string functionName
where attribute.getType().hasName("FunctionNameAttribute")
and functionName = attribute.getArgument(0).getValue()
and not functionName.regexpMatch("XMas.*")
select attribute, "This function name is not XMas compliant"