# http-downloader
Тестовые задания для самообучения по многопоточности.  
Http downloader для списка URL из файла.  
*Command line parametrs:*
* -n количество одновременно качающих потоков (1,2,3,4....)
* -l общее ограничение на скорость скачивания, для всех потоков, размерность - байт/секунда (можно использовать суффиксы k,m (k=1024, m=1024*1024))
* -f путь к файлу со списком ссылок
* -o имя папки, куда складывать скачанные файлы  

Формат файла со ссылками:  
	<HTTP ссылка><пробел><имя файла, под которым его надо сохранить>  
пример:  
	http://example.com/archive.zip my_archive.zip  
	http://example.com/image.jpg picture.jpg  
Варианты:  
	1. Стандартная многопоточность с мьютексами, семафорами и т. д. (см eax.me)  
	2. Использование процессов ОС вместо потоков  
	3. Если возможно, использовать легковесные потоки, событийно ориентированное программирование, транзакционная память.  
