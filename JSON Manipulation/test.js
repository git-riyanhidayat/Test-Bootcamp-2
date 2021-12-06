document.querySelector('#ambil').addEventListener('click',function(e)
    {
        ambilData();        
    });
     
    function ambilData()
    {
        console.log('Sebelum fetch (baris 19)');
         
        fetch('/data.json')
            .then(function(res)
            {
                console.log('Ini dalam fetch (baris 24)');
                console.log('res:',res);
                return res.json();
            })
            .then(function(jsonku)
            {
                console.log(jsonku);
                let hasil = "Daftar nama: ";
                 
                jsonku.forEach(function(siswa)
                {
                    hasil += `${siswa.nis} - ${siswa.nama} - ${siswa.kalurahan} `;
                     
                });
 
                document.querySelector('#tampilan').innerHTML = hasil;
                console.log('Selesai menampilkan data');                
            })
            .catch(function(err)
            {
                console.log(err);
            });
 
        console.log('Setelah fetch (baris 47)');                
    }
