* We're going to setup a simple and responsive Library UI where the user can browser our collection of books and select one.
* The configuration root for our code will live in LibraryView.cs, which is already in the Library.unity scene and prepopulated with data.
* Our books are defined by a collection of BookModelData ScriptableObjects
* Part 1 (Selecting a Book)
    * Add a button to the UI that, when tapped changes the text at the bottom to say "You have selected A Book"
    * Convert that button to use a BookModelData object and, when pressed, change the description text to the title of the book.
* Part 2 (Browsing the collection)
    * Create a container that will automatically layout a set of dynamically created book buttons.
    * Using LibraryView as our base, dynamically populate a scrollable list of buttons with all of the stories in LibraryView.books
* Part 3 (Adding Juice)
    * To help the users pick a book, lets improve our buttons so that they have both the cover image and the title of the story.
    * When the user clicks on one of the buttons, lets make the description at the bottom populate with the following: 
        * The title
        * The author
        * The list of tags
        * The blurb
    * As a finishing touch, lets layout and style all of the description information so that it's easier for the user to digest.
