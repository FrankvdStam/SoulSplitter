pub fn scan(code: &[u8], pattern: &[Option<u8>]) -> Option<usize>
{
    if code.len() == 0
    {
        return None;
    }

    for i in 0..code.len() - pattern.len()
    {
        let mut found = true;
        for j in 0..pattern.len()
        {
            if let Some(byte) = pattern[j]
            {
                if byte != code[i + j]
                {
                    found = false;
                    break;
                }
            }
        }
        if found
        {
            return Some(i);
        }
    }
    return None;
}


pub fn to_pattern(str: &str) -> Vec<Option<u8>>
{
    let mut vec = Vec::new();
    for substr in str.split(" ")
    {
        if substr == "?"
        {
            vec.push(None);
        }
        else
        {
            vec.push(Some(u8::from_str_radix(substr, 16).expect("invalid hex string in pattern string")));
        }
    }
    return vec;
}