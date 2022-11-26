/**
 * @name Check Empty Block
 * @id xmas-check-empty-blocks
 * @kind problem
 * @problem.severity recommendation
 */

 import csharp

 from BlockStmt b
 where b.getNumberOfStmts() = 0
 select b, "This is an empty block."