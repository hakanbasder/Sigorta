select * from bilgilerr

select * from Markalar

//* �nemli **// 


SELECT mrk.MarkaID, mrk.MarkaAdi,mdl.ModelAdi, mdl.ModelID
FROM MODELLER  as mdl
INNER JOIN Markalar as mrk ON mrk.MarkaID = mdl.MarkaID

SELECT ModelAdi FROM Modeller
WHERE MarkaID


//* �nemli *// 


select * from Markalar 