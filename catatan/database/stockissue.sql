SELECT   tbleximdocdetail.TRANSNO,tbleximdocdetail.ID,tbleximdocdetail.NOAJU,tbleximdocdetail.ITEMSID,tbleximdocdetail.STYLEID,tbleximdocdetail.CURRENCY,tbleximdocdetail.PRICE,tbleximdocdetail.KURS,tbleximdocdetail.TOTAL, tblmitems.DESCRIPTION,
View_Exim.QUANTITY,View_Exim.UOM
FROM tbleximdocdetail 
INNER JOIN View_Exim ON View_Exim.TRANSNO=tbleximdocdetail.TRANSNO
INNER JOIN tblmitems ON tblmitems.ITEMSID=tbleximdocdetail.ITEMSID
WHERE NOAJU = 'a'