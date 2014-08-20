SELECT * FROM tblcosting 
INNER JOIN tblcostingdetail ON tblcosting.COSTINGNO=tblcostingdetail.COSTINGNO
INNER  JOIN tblmitems ON tblmitems.ITEMSID=tblcosting.ITEMSID
INNER JOIN tblmcategory ON tblmcategory.CATEGORYID=tblcosting.CATEGORYID
INNER JOIN tblmtype ON tblmtype.TYPEID=tblcosting.TYPEID
INNER JOIN tblmcustvend ON tblmcustvend.CUSTVENDCODE=tblcosting.CUSTVENDCODE
INNER JOIN tblmcost ON tblmcost.COSTID=tblcostingdetail.COSTID
WHERE tblcosting.COSTINGNO = 'COST.2014.0004'