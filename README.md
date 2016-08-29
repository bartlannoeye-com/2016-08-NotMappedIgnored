# Entity Framework Core NotMappedAttribute ignored repro

While porting our database from Lex.db to Entity Framework (first RC1 and then RTM), we ran into an issue where the NotMapped attribute was ignored. This resulted in an error while creating our model.

Blog post: http://www.bartlannoeye.com/blog/entity-framework-core-notmapped-attribute-ignored