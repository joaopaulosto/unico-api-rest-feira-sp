USE MASTER
GO
ALTER database DB_FEIRA_LIVRE set offline with ROLLBACK IMMEDIATE;
DROP database DB_FEIRA_LIVRE;
