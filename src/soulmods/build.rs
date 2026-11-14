use std::fs::File;
use std::io::Read;

fn main()
{
    let version = read_version().unwrap_or_else(|_| String::from("0.0.0"));
    println!("cargo:rustc-env=VERSION={}", version);
}

fn read_version() -> Result<String, ()>
{
    let mut f = File::open("../../Directory.Build.props").map_err(|_| ())?;
    let mut buffer = String::new();
    f.read_to_string(&mut buffer).map_err(|_| ())?;

    let doc = roxmltree::Document::parse(buffer.as_str()).map_err(|_| ())?;
    let find_result = doc.descendants().find(|n| n.tag_name().name().to_ascii_lowercase()  == "version");
        
    if let Some(version_node) = find_result
    {
        if let Some(version) = version_node.text()
        {
            return Ok(version.to_string());
        }
        //println!("cargo:warning=MESSAGE {:?}", version_node.text());
    }
    Err(())
}