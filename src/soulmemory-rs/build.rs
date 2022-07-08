use std::{env, fs};
use std::path::PathBuf;
use cc::Build;

#[cfg(target_arch = "x86_64")]
fn main()
{
    if env::var("CARGO_CFG_TARGET_POINTER_WIDTH").unwrap() == "64" && false //temporarly hadcoding this to not assemble
    {
        //Get a print outdir
        let out_dir = PathBuf::from(env::var_os("OUT_DIR").unwrap());

        println!("cargo:warning=out_dir:{}", out_dir.display());

        //Collect asm files under src/asm/, print them, mark them as part of the build - cargo will know when they change and recompile.
        let files = fs::read_dir("src/asm/").unwrap().map(|f| fs::canonicalize(f.unwrap().path()).unwrap()).collect::<Vec<PathBuf>>();
        println!("cargo:warning=Found assembly files:");
        for f in &files
        {
            println!("cargo:warning={}", f.display());
            println!("cargo:rerun-if-changed={}", f.display());
        }

        //assemble and link
        Build::new().files(files).compile("soullib");
        println!("cargo:rustc-link-search={}", out_dir.display());
    }
}