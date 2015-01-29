SELECT 
tblgrndetail.ITEMSID,
tblgrndetail.UOM,
CASE WHEN date(tblgrn.DATE) <  date('2014-11-27 11:14:16') THEN tblgrndetail.QUANTITY ELSE 0 END OPENING,
CASE WHEN date(tblgrn.DATE) BETWEEN date('2014-11-27 11:14:16') AND date('2014-11-27 11:14:16')THEN tblgrndetail.QUANTITY ELSE 0 END PEMASUKAN,
0 PENGELUARAN, 0 PENYESUAIAN,
CASE WHEN date(tblgrn.DATE) <= date('2014-11-27 11:14:16') THEN tblgrndetail.QUANTITY ELSE 0 END CLOSING,
0 STOCKOPNAME,0 SELISIH
FROM tblgrn
INNER JOIN tblgrndetail ON tblgrndetail.GRNNO=tblgrn.GRNNO
WHERE tblgrndetail.JENIS='RAW'