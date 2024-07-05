const fs = require('fs')

let input = fs.readFileSync(`./events.txt`).toString()
let output = `// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using System.Xml.Serialization;

namespace SoulMemory.DarkSouls1
{
    [XmlType(Namespace = "SoulMemory.DarkSouls1")]
    public enum PresetFlag : uint
    {
`

let i = 0
let entries = {}

for(let line of input.split(/\r?\n/)) {

  if(!/\|/.test(line)) continue
  let id = line.split('|')[0]
  let name = line.split('|')[1] || `Unknown${i++}`
  name = name.replace(/\"/g, '\\\"')
  let formatted = name.replace(/^\s*/, '')
                      .replace(/^[^a-z]/i, 'A')
                      .replace(/,\s*/g, '_')
                      .replace('\'', '')
                      .replace(/[^\w\d\s]/gi, '')
                      .replace(/\s/g, '_')


  let found 
  for(let e of Object.values(entries)) {
    if (e.id === id)
      found = e
  }
  if(found) continue

  let j = 1
  while(entries[formatted]) {
    formatted = formatted.replace(/\_*\d*$/, `_${j++}`)
  }
  entries[formatted] = {
    id, name
  }
}


Object.keys(entries).sort((a,b) => entries[a].id - entries[b].id).forEach(e => {

  output += `
    [AnnotationAttribute(Name = "${entries[e].id} | ${entries[e].name}")]
    ${e} = ${entries[e].id},
`

  console.log(`${e}:`)
  console.log(`${entries[e].id} -  ${entries[e].name}\n`)

})


output += `    }

}
`

fs.writeFileSync('../PresetFlag.cs', output)

console.log(`Parsed ${Object.keys(entries).length} event ids...`)