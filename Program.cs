class program {


    public static void menyapa(string namaOrang = "budi", int umur = 12){
        Console.WriteLine("Halo "+namaOrang + " Umurmu " + umur);
    }

    public static int hitung(int nomor){
        int perkalian = nomor * nomor;
        return perkalian;
    }

    public static double pembagian(){
        return 1;
    }

    public static string nama(string nama){
        return nama+" halo";
    }

    public static void methodSwitch(int nomer){
        switch(nomer){
            case 0:
            Console.WriteLine("Bilangan mu: "+nomer);
            break;

            default:
            Console.WriteLine("Tidak terdaftar");
            break;
        }
    }

    public static int methodSwitchOn(int nomer){
        if(nomer > 0){return nomer * 2;}else{return nomer + 2;}
    }
    

    public static void Main(){
        menyapa("ucup", 17);
       methodSwitch(0);
       methodSwitch(1);
       Console.WriteLine(methodSwitchOn(0));
       Console.WriteLine(methodSwitchOn(1));
       Console.WriteLine(methodSwitchOn(2));
    }

}
// perubahan 1
// perubahan 2
// Bismillah bisa. Gas CM fi


                







