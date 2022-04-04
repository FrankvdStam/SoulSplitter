use rust_memory::{scan, to_pattern};
use rust_memory::pointer::Pointer;


fn main()
{
    let elden_ring_names = vec![String::from("eldenring.exe"), String::from("start_protected_game.exe")];
    let mut process = rust_memory::create_process(elden_ring_names);

    let code = process.get_code();

    //println!("{:#08x?}", scan(&code, &to_pattern("48 8b 05 ? ? ? ? 4c 8b 40 08 4d 85 c0 74 0d 45 0f b6 80 be 00 00 00 e9 13 00 00 00")));
    //println!("{:#08x?}", scan(&code, &to_pattern("48 8b 05 ? ? ? ? 48 89 98 70 84 01 00 4c 89 ab 74 06 00 00 4c 89 ab 7c 06 00 00 44 88 ab 84 06 00 00 41 83 7f 4c 00")));
    println!("{:#08x?}", scan(&code, &to_pattern("48 8b 0d ? ? ? ? 48 8b 53 08 48 8b 92 d8 00 00 00 48 83 c4 20 5b")));
    //println!("{:#08x?}", scan(&code, &to_pattern("48 c7 44 24 20 fe ff ff ff 0f 29 74 24 40 0f 28 f0 48 8b 0d ? ? ? ? 0f 28 c8 f3 0f 59 0d ? ? ? ?")));
    //println!("{:#08x?}", scan(&code, &to_pattern("48 8b c4 55 57 41 56 48 8d 68 b8 48 81 ec 30 01 00 00 48 c7 44 24 40 fe ff ff ff 48 89 58 18 48 89 70 20")));

    let base = process.get_base_address();
    let ptr = Pointer::new(process, base + scan(&code, &to_pattern("48 8b 0d ? ? ? ? 48 8b 53 08 48 8b 92 d8 00 00 00 48 83 c4 20 5b")).unwrap(), vec![0x0], true);

    println!("{}", base);
    println!("{}", ptr);
    println!("{}", ptr.read_u8(Some(1832)));

    return;
    loop
    {
        process.refresh();
        println!("{}", process.read_i32(0x7FF47B6C0200));
    }
}
