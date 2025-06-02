/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package entity;

import java.io.Serializable;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;

/**
 *
 * @author Planet
 */
@Entity
@Table(name = "bookmaster")
@NamedQueries({
    @NamedQuery(name = "Bookmaster.findAll", query = "SELECT b FROM Bookmaster b"),
    @NamedQuery(name = "Bookmaster.findByBookID", query = "SELECT b FROM Bookmaster b WHERE b.bookID = :bookID"),
    @NamedQuery(name = "Bookmaster.findByBookName", query = "SELECT b FROM Bookmaster b WHERE b.bookName = :bookName"),
    @NamedQuery(name = "Bookmaster.findByAuthor", query = "SELECT b FROM Bookmaster b WHERE b.author = :author"),
    @NamedQuery(name = "Bookmaster.findByPublisherName", query = "SELECT b FROM Bookmaster b WHERE b.publisherName = :publisherName"),
    @NamedQuery(name = "Bookmaster.findBySynopsis", query = "SELECT b FROM Bookmaster b WHERE b.synopsis = :synopsis")})
public class Bookmaster implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Basic(optional = false)
    @Column(name = "bookID")
    private Integer bookID;
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 250)
    @Column(name = "bookName")
    private String bookName;
    @Size(max = 250)
    @Column(name = "author")
    private String author;
    @Size(max = 250)
    @Column(name = "publisherName")
    private String publisherName;
    @Size(max = 250)
    @Column(name = "synopsis")
    private String synopsis;

    public Bookmaster() {
    }

    public Bookmaster(Integer bookID) {
        this.bookID = bookID;
    }

    public Bookmaster(Integer bookID, String bookName) {
        this.bookID = bookID;
        this.bookName = bookName;
    }

    public Integer getBookID() {
        return bookID;
    }

    public void setBookID(Integer bookID) {
        this.bookID = bookID;
    }

    public String getBookName() {
        return bookName;
    }

    public void setBookName(String bookName) {
        this.bookName = bookName;
    }

    public String getAuthor() {
        return author;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    public String getPublisherName() {
        return publisherName;
    }

    public void setPublisherName(String publisherName) {
        this.publisherName = publisherName;
    }

    public String getSynopsis() {
        return synopsis;
    }

    public void setSynopsis(String synopsis) {
        this.synopsis = synopsis;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (bookID != null ? bookID.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Bookmaster)) {
            return false;
        }
        Bookmaster other = (Bookmaster) object;
        if ((this.bookID == null && other.bookID != null) || (this.bookID != null && !this.bookID.equals(other.bookID))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "entity.Bookmaster[ bookID=" + bookID + " ]";
    }
    
}
