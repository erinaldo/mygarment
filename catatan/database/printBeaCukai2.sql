SELECT @dateFrom dateFrom,@dateTo dateTo,dateTo,tbleximdoc.DOCTYPE,  tbleximdoc.DOCNO,tbleximdoc.DOCDATE,tbleximdocdetail.TRANSNO,tblgin.DATE,tblmcustvend.NAME,tbleximdocdetail.ITEMSID,tblmitems.DESCRIPTION,tblgindetail.UOM,tblgindetail.QUANTITY,tbleximdocdetail.KURS,tbleximdocdetail.TOTAL  FROM tbleximdoc  INNER JOIN tbleximdocdetail ON tbleximdoc.AJUNO=tbleximdocdetail.NOAJU  INNER JOIN tblgin ON tbleximdocdetail.TRANSNO=tblgin.GINNO INNER JOIN tblgindetail ON tblgindetail.GINNO=tblgin.GINNO INNER JOIN tblmcustvend ON tblmcustvend.CUSTVENDCODE=tblgin.CUSTVENDCODE INNER JOIN tblmitems ON tblmitems.ITEMSID=tbleximdocdetail.ITEMSID WHERE tbleximdoc.`TYPE`='PENGELUARAN' AND date(DOCDATE) BETWEEN date(@dateFrom) AND date(@dateTo)