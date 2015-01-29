SELECT tblcutt.CUTNO, tblcutt.STYLEID,tblcutt.COLORID,tblcutt.DATE,tblcutt.NOOFCUT,tblcutt.NOOFLAYER,tblcutt.OFFICER,

MAX(case when NOURUT=0 then tblproductionsize.SizeID end ) Size0,
MAX(case when NOURUT=1 then tblproductionsize.SizeID end ) Size1,
MAX(case when NOURUT=2 then tblproductionsize.SizeID end ) Size2,
MAX(case when NOURUT=3 then tblproductionsize.SizeID end ) Size3,
MAX(case when NOURUT=4 then tblproductionsize.SizeID end ) Size4,

SUM(case when NOURUT=0 then tblcuttdetail.QTY end ) Qty0,
SUM(case when NOURUT=1 then tblcuttdetail.QTY end ) Qty1,
SUM(case when NOURUT=2 then tblcuttdetail.QTY end ) Qty2,
SUM(case when NOURUT=3 then tblcuttdetail.QTY end ) Qty3,
SUM(tblcuttdetail.QTY)  TOTAL

FROM  tblcuttdetail 
INNER JOIN  tblcutt ON tblcutt.CUTNO=tblcuttdetail.CUTNO
RIGHT OUTER JOIN tblproductionsize  ON tblproductionsize.STYLEID=tblcutt.STYLEID AND tblproductionsize.SIZEID=tblcuttdetail.SIZEID
/*INNER JOIN tblproduction ON tblproduction.STYLEID=tblcutt.STYLEID AND tblproduction.COLORID=tblcutt.COLORID*/
LEFT OUTER JOIN tblproduction ON tblproduction.STYLEID=tblproductionsize.STYLEID AND tblproduction.COLORID=tblcutt.COLORID

GROUP BY tblproduction.STYLEID,tblproduction.COLORID,tblcutt.DATE,tblcutt.NOOFCUT,tblcutt.CUTNO






