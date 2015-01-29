SELECT '2014-12-22' dateFrom,'2014-12-22' dateTo,tbleximdoc.DOCTYPE,  tbleximdoc.DOCNO,tbleximdoc.DOCDATE,tbleximdocdetail.TRANSNO,tblgrn.DATE,tblgrn.PONO,tblmcustvend.NAME,tbleximdocdetail.ITEMSID,tblmitems.DESCRIPTION,tblgrndetail.UOM,tblgrndetail.QUANTITY,tbleximdocdetail.KURS,tbleximdocdetail.TOTAL
FROM tbleximdoc
INNER JOIN tbleximdocdetail ON tbleximdoc.AJUNO=tbleximdocdetail.NOAJU
INNER JOIN tblgrn ON tbleximdocdetail.TRANSNO=tblgrn.GRNNO
INNER JOIN tblgrndetail ON tblgrndetail.GRNNO=tblgrn.GRNNO
INNER JOIN tblpurchase ON tblpurchase.PONO=tblgrn.PONO
INNER JOIN tblmcustvend ON tblmcustvend.CUSTVENDCODE=tblpurchase.CUSTVENDID
INNER JOIN tblmitems ON tblmitems.ITEMSID=tbleximdocdetail.ITEMSID
WHERE tbleximdoc.`TYPE`='PEMASUKAN' AND date(DOCDATE) BETWEEN date('2014-12-22') AND date('2014-12-22')