//1.ArrayList


using System.Collections;
ArrayList list = new ArrayList();
//-Them phan tu vao ArrayList
list.Add("MAi");
list.Add("B");
list.Add(9);
list.Add(7.2);
//-Truy xuat phan tu trong ArrayList
Console.WriteLine(list[0]);
//Chen phan tu vao trong ArrayList
list.Insert(1, "Dung");
//-Xoas phan tu trong ArrayList
//list.Remove("Dung"); //Xoa theo phan tu
list.Remove(1);//Xoa theo chi so
//-Tim kiesm
Console.WriteLine(list.IndexOf('8'));// Tra ve vi tri dau tien cuar '8'
Console.WriteLine(list.LastIndexOf('3'));// Tra ve vi tri cuoi cung cua '3'
//-Duyet cac phan tu cp trong ArrayList
foreach(object item in list)
{
    Console.WriteLine(item);
}

//2. HashTable
//- la 1 tap hop cac phan tu
//- Moi phan tu la mot cap <Key,Value>
//-Key phai la duy nhat va khac null
//-Truy xuat phan tu thong qua key.
Hashtable ht = new Hashtable();
//-them phan tu vao Hashtable
ht.Add("Mai",10);
ht.Add(7,"Hien");
ht.Add("Tien", 100);
//-Xoa phan tu trong Hashtable
//ht.Remove("Mai");//Xoa theo Key
//-Truy xuat theo key
Console.WriteLine(ht.["Tien"]);
//- Duyet cach phan tu:
//+ duyet theo chieu doc
//ICollection keys = ht.keys;
//foreach ( object key in keys)
//{
//    Console.WriteLine($"{key} : {ht.key}");
//}
//+duyet theo chieu ngang:
foreach ( DictionaryEntry entry in ht)
{
    Console.WriteLine($"{entry.Key}");
}
