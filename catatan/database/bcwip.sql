SELECT '2014-12-01', '2014-12-31' , StyleID, Description,CategoryID,Style,ExtraDesc,
SUM(RECCMT)	RECCMT, 
SUM(ISSUEDCMT)	ISSUEDCMT
FROM(
SELECT 	
	StyleID, CategoryID,Description, UOM, Style,ExtraDesc,
	0  RECCMT,
	case when  Tanggal BETWEEN '2014-12-01' AND '2014-12-31' AND RECEIVEFROM='2'  then  Quantity   else 0 end ISSUEDCMT 
FROM materialissue
union all
SELECT 	
	StyleID, CategoryID, Description, UOM,Style,ExtraDesc,
	case when  Tanggal BETWEEN '2014-12-01' AND '2014-12-31' AND RECEIVEFROM='2'  then  Quantity   else 0 end RECCMT ,
		0  ISSUEDCMT
FROM materialreceive
)DATA
WHERE DATA.CategoryID <>'AST' AND DATA.CategoryID<>'SCR'
GROUP BY StyleID, Description,CategoryID,Style,ExtraDesc
HAVING SUM(ISSUEDCMT)-SUM(RECCMT)>0
;