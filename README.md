We're going to setup a simple and responsive Library UI where the user can browser our collection of books and select one.
* The configuration root for our code will live in LibraryView.cs, which is already in the Library.unity scene and prepopulated with data.
* Our books are defined by a collection of BookModelData ScriptableObjects


-   Add a menu to the bottom half of the UI with the a collection of buttons, where each button represents one of the BookDataModels in Canvas' Library component
-  The button collection should dynamically populate itself at start based on list of books in Canvas.Library.books. 
-  The button collection should automatically lay itself out to fit any screen size and should support scrolling if there are more books than fit in the UI container.
- When a button is clicked, the following should happen:
    - The Text that says "Selected Book Information goes here" should be updated to the title of the book.
    - The cover of the book should appear above the text, as large as possible without it or the text exceeding the dark gray UI Panel.

