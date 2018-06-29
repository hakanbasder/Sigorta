select * from bilgilerr

select * from Markalar

//* Önemli **// 


SELECT mrk.MarkaID, mrk.MarkaAdi,mdl.ModelAdi, mdl.ModelID
FROM MODELLER  as mdl
INNER JOIN Markalar as mrk ON mrk.MarkaID = mdl.MarkaID

SELECT ModelAdi FROM Modeller
WHERE MarkaID


//* Önemli *// 


select * from Markalar 