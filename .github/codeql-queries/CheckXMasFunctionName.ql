/**
 * @name Check XMas Function Name
 * @id check-xmas-function-name
 * @kind problem
 * @problem.severity error
 */

import csharp

from Attribute attribute
where attribute.getType().hasName("FunctionNameAttribute")
and not attribute.getArgument(0).getValue().regexpMatch("XMas")
select attribute, "This function name is not XMas compliant"