SELECT tblcutt.CUTNO,tblcutt.STYLEID,tblcutt.COLORID,tblcutt.DATE,tblcutt.NOOFCUT,
MAX(case when NOURUT=0 then tblproductionsize.SizeID end ) Size0,
MAX(case when NOURUT=1 then tblproductionsize.SizeID end ) Size1,
MAX(case when NOURUT=2 then tblproductionsize.SizeID end ) Size2,
MAX(case when NOURUT=3 then tblproductionsize.SizeID end ) Size3,
MAX(case when NOURUT=4 then tblproductionsize.SizeID end ) Size4,
MAX(case when NOURUT=5 then tblproductionsize.SizeID end ) Size5,
MAX(case when NOURUT=6 then tblproductionsize.SizeID end ) Size6,
MAX(case when NOURUT=7 then tblproductionsize.SizeID end ) Size7,

/*untuk quantity*/
SUM(case when NOURUT=0 then tblcuttdetail.QTY end ) Qty0,
SUM(case when NOURUT=1 then tblcuttdetail.QTY end ) Qty1,
SUM(case when NOURUT=2 then tblcuttdetail.QTY end ) Qty2,
SUM(case when NOURUT=3 then tblcuttdetail.QTY end ) Qty3,
SUM(tblcuttdetail.QTY)  TOTAL
FROM tblproductionsize  
LEFT OUTER JOIN tblcuttdetail ON tblproductionsize.SIZEID=tblcuttdetail.SIZEID
LEFT OUTER JOIN tblcutt ON tblcutt.CUTNO=tblcuttdetail.CUTNO
LEFT OUTER JOIN tblproduction ON tblproduction.STYLEID=tblproductionsize.STYLEID and tblproduction.COLORID=tblcutt.COLORID

WHERE tblcutt.STYLEID = '20.19393.10.81' AND tblcutt.COLORID='Black' 

GROUP BY tblcutt.STYLEID,tblcutt.COLORID,tblcutt.DATE,tblcutt.NOOFCUT,tblcutt.CUTNO